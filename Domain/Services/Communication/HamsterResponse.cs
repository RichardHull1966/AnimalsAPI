using AnimalsAPI.Domain.Models;

namespace AnimalsAPI.Domain.Services.Communication
{
    public class HamsterResponse : BaseResponse
    {
        public Hamster Hamster { get; private set; }

        private HamsterResponse(bool success, string message, Hamster hamster) : base(success, message)
        {
            Hamster = hamster;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="hamster">Saved hamster.</param>
        /// <returns>Response.</returns>
        public HamsterResponse(Hamster hamster) : this(true, string.Empty, hamster)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public HamsterResponse(string message) : this(false, message, null)
        { }
    }
}