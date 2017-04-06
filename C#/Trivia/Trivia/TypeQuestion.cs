using System.Collections.Generic;

namespace Trivia
{
    public class TypeQuestion
    {
        /*Property*/
        public string Type { get; private set; }

        public List<Question> Questions;


        /*Constructeur*/
        public TypeQuestion(string type)
        {
            Questions = new List<Question>();
            Type = type;
        }


    }
}