namespace _114510RecuperatorioScafolding.Response
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public T? Data { get; set; }
        public string? Message { get; set; }
    }
}
