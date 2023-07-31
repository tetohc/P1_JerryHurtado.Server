namespace P1_JerryHurtado.Server.Models._Socket
{
    /// <summary>
    /// Clase modelo para comunicación Cliente/Servidor, basado en el ejemplo proporcionado en el curso.
    /// </summary>
    public class ClientRequest<T>
    {
        public int TypeRequest { get; set; }
        public string UserId { get; set; }
        public T Data { get; set; }
    }
}