using System;

namespace zoo
{
    public class Animal{

        public string sleep(){//this is a method
            return "Zzzzzz...";
        }

        virtual public string dance(){
        //virtual allows behaviors to be redefined by children

            return null;
        }

    }

    public class Dog: Animal{//anything put into Animal, now inheritence to Dog
        //override is a keyword to override a parent function
        override public string dance(){
            return "Rag-Top Don't Stop";
        }
    }


}
