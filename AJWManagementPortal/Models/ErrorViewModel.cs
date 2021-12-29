namespace AJWManagementPortal.Models
{

    //This Model refer to Error view model but now its Unknown--
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
