using MoviesAPI.Domain.Models;

namespace MoviesAPI.Domain.Services.Communication
{
    public class SaveHamsterResponse : BaseResponse
    {
        public Hamster Hamster { get; private set; }

        private SaveHamsterResponse(bool success, string message, Hamster hamster) : base(success, message)
        {
            Hamster = hamster;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="hamster">Saved hamster.</param>
        /// <returns>Response.</returns>
        public SaveHamsterResponse(Hamster hamster) : this(true, string.Empty, hamster)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SaveHamsterResponse(string message) : this(false, message, null)
        { }
    }
}