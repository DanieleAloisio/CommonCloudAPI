namespace CommonCloud.API.Dto
{
    public class InfoDto
    {
        public string message { get; set; }

        public InfoDto(String Message)
        {
            this.message = Message;
        }
    }
}
