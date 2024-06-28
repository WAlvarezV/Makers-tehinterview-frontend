namespace Makers.TexhInterview.Frontend.Client
{
    /// <summary>
    /// The api result.
    /// </summary>
    public class ApiResult
    {
        /// <summary>
        /// Gets or Sets the id.
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Gets or Sets the name.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Gets or Sets the air date.
        /// </summary>
        public string air_date { get; set; }
        /// <summary>
        /// Gets or Sets the episode.
        /// </summary>
        public string episode { get; set; }
        /// <summary>
        /// Gets or Sets the characters.
        /// </summary>
        public List<string> characters { get; set; }
        /// <summary>
        /// Gets or Sets the url.
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// Gets or Sets the created.
        /// </summary>
        public DateTime created { get; set; }
    }
}
