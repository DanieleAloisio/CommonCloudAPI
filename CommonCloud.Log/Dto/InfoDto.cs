namespace CommonCloud.API.Dto
{
    public class InfoDto
    {
        public string message { get; set; }

        public InfoMsg(String Message)
        {
            this.message = Message;
        }
    }
}
