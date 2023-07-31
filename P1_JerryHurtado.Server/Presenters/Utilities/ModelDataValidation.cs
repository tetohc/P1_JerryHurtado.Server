using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Server.Presenters.Utilities
{
    public static class ModelDataValidation
    {
        /// <summary>
        /// Se encarga de verificar si se cumplen las reglas de validación establecidas para el modelo.
        /// </summary>
        /// <param name="model">object: objeto que se validará.</param>
        public static void Validate(object model)
        {
            string errorMessage = "";
            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, validationResults, true);

            if (!isValid)
            {
                foreach (var item in validationResults)
                    errorMessage += $"- {item.ErrorMessage}\n";
                throw new Exception(errorMessage);
            }
        }
    }
}