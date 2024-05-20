namespace Api_Rest_1.Entities
{
    public class DevEventSpeaker
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }
        public string TalkTitle {  get; set; }
        
        public string TalkDescription { get; set; }
        public string LinkedInProfile { get; set; }
    }
}