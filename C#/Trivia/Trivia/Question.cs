namespace Trivia
{
    public class Question
    {
        /*Property*/

        public string Enonce { get; private set; }

        public string Reponse { get; set; }

        public TypeQuestion TypeQuestion { get; private set; }

        /*Constructeur*/
        public Question(TypeQuestion typeQuestion, string enonce, string reponse)
        {
            TypeQuestion = typeQuestion;
            Enonce = enonce;
            Reponse = reponse;
        }

        public override string ToString()
        {
            return "La question posée est : " + Enonce;
        }
    }
}