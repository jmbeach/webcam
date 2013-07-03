namespace Webcam.Models
{
    public class Photo
    {
        public string Name { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Photo(){}

        /// <summary>
        /// Sets a new Photoobject
        /// </summary>
        /// <param name="name"></param>
        public Photo(string name)
        {
            this.Name = name; 
        }
    }
}