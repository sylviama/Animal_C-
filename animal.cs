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

        private string respiraton(){//private even cannot be used by its children
            return "breath!";
        }

        protected string swim(){//protected could only be used inside of the family, not outside
            return "swoosh";
        }

    }

    public class Dog: Animal{//anything put into Animal, now inheritence to Dog
        //override is a keyword to override a parent function
        override public string dance(){
            
            return "Rag-Top Don't Stop "+this.swim();;
        }


    }

    public class Cat: Animal{
        //Ad-hoc Polymorphism same method, diff argument types
        public string meow(){
            return "meow";
        }

        public string meow(int number_of_pets){
            if(number_of_pets<=0){
                return this.meow();//"this" means class Cat?
            }else{
                return "meow, you've pet me!";
            }
        }

        private string purr(){
            return "purr!";
        }

        public string neowThenPurr(){
            return this.meow()+" "+ this.purr();
        }

    }


}
