using Microsoft.AspNetCore.Mvc;

namespace AppStoreServerLibrary.WebAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class AppStoreController : ControllerBase
    {

        private readonly ILogger<AppStoreController> _logger;
        private readonly IAppStoreServerAPIClient _appStoreServerAPIClient;

        public AppStoreController(ILogger<AppStoreController> logger, IAppStoreServerAPIClient appStoreServerAPIClient)
        {
            _logger = logger;
            _appStoreServerAPIClient = appStoreServerAPIClient;
        }

        [HttpGet]
        [Route("/test")]
        public async Task<IResult> Get()
        {
            try
            {
                var testNotification = await  _appStoreServerAPIClient.RequestTestNotification();
                return Results.Ok(testNotification);
            }
            catch (Exception e)
            {
                _logger.LogError("{Exception}", e);
                return Results.Problem();
            }
        }
    }
}
