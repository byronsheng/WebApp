
namespace SneakerWatcher.Services
{
    public class GetdataService
    {
        readonly string _url;

        public GetdataService(string url) 
        {
            url = _url;
        }


        public string GetReadyOfSneaker()
        {
            var getPage = new GetPageUsingUrl(_url);

            //ToDo get useful information from page
            return getPage.GetPage();
        }

        
    }
}
