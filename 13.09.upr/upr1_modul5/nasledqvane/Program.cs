using System;

namespace nasledqvane
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Petar", 20, "Sofia", 3, "Informatics");
            st.Introduce();
            st.IntroduceMyself();
        }
    }
}
