namespace Trivia
{
    public class Question
    {
        /*Property*/

        public string Enonce { get; private set; }

        public string Reponse { get; set; }


        /*Constructeur*/
        public Question(string enonce, string reponse)
        {
            Enonce = enonce;
            Reponse = reponse;
        }

        public override string ToString()
        {
            return "La question posée est : " + Enonce;
        }
    }
}