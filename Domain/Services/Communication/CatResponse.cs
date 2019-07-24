using AnimalsAPI.Domain.Models;

namespace AnimalsAPI.Domain.Services.Communication
{
    public class CatResponse : BaseResponse
    {
        public Cat Cat { get; private set; }

        private CatResponse(bool success, string message, Cat cat) : base(success, message)
        {
            Cat = cat;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="cat">Saved cat.</param>
        /// <returns>Response.</returns>
        public CatResponse(Cat cat) : this(true, string.Empty, cat)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public CatResponse(string message) : this(false, message, null)
        { }
    }
}