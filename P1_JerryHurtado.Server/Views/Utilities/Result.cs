namespace P1_JerryHurtado.Server.Views.Utilities
{
    public static class Result
    {
        /// <summary>
        /// Muestra un mensaje de respuesta al flujo realizado.
        /// </summary>
        /// <param name="message">string: Mensaje que se mostrará.</param>
        /// <param name="isSuccessful">bool: Resultado del proceso realizado.</param>
        public static void ShowResponse(string message, bool isSuccessful)
        {
            if (isSuccessful)
                MessageBox.Show(message, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}