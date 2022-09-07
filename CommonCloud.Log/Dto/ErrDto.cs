namespace CommonCloud.API.Dto
{
    public class ErrDto
    {
        public ErrDto(string message, int errcode)
        {
            this.message = message;
            this.errcode = errcode;
            this.data = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public string message { get; set; }
        public int errcode { get; set; }
        public string data { get; set; }

    }
}
