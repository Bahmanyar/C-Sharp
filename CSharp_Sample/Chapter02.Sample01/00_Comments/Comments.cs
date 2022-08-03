using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02.Sample01._00_Comments
{
    internal class Comments
    {
        #region [- Chapter 2 -]
        //TopLevel Templates :
        //Ommit many codes for start in Program.cs >> from c# 9

        //use "var":
        //instead of declaring DataType >> from c# 3

        //Target type new expression :
        //[Person p=new()]; >> from c# 9 

        // Variable vs constant:
        // const srting s="A";
        // readonly 

        //null for value types :
        //int? or Nullable<int>
        //HasValue property for types
        //built-in nullable in .net6 apps >>   <Nullable>enable</Nullable> in click on the project name

        //nint & uint in c#9

        //put binary or hexadecimal in int  [0b & 0x] >> from c#9

        //separator for numbers [ int x=123_321_432] >> from c#7

        //Half data type >> C#5
        //Single data type >> C#5

        //if:
        //Ex1:
        //if(object is Person)
        //{...}
        //Ex2:
        //if(object is Person p)
        //{...}

        //switch:
        //switch expression >> c#10

        //loops:
        //pre-test & post-test loop types
        //Continue,return,break in loops

        //NameSpace:
        //file scope NameSpace >> C#10
        //using myNS= NS1.NS2.NS3; >> use "myNS" instead of long line of name spaces
        //Global using >> C#10  --> global using  NS1.NS2.NS3; --> global for all assembly area
        //Implicit using >> C#6 --> very useful

        //xml documentation --> xml file in which system collects xml comments


        #endregion

        #region [- Chapter 3 -]
        //Class
        //Structure
        //Record
        //Tuple
        //Value Type vs. Refrence Type
        //by value vs. by refernce data transfering
        //readonly vs constant
        #region [- Field -]        
        //When we need to store data in the inner class algorithms
        //private or private readonly  
        //states for inner logic class
        #endregion
        #endregion

        #region [- Chapter 6 -]
        //var result = input == 0 ? "Zero" : "NotZero";

        #region [- Checked block -]
        //Checked block:
        //Checking overhead has many cpu cost and it is not implicit. 
        //not good : tick "check overflow automatically in project properties
        #endregion

        //is
        //as
        //NameOf() --> prevent hard coding

        #region [- Cheking Null -]
        #region [- First Way -]
        //Check null with traid operator
        // int b = a == null ? 0: a.value;  
        #endregion

        #region [- Second Way : good -]
        //Check null with ??
        // int b = a ?? 0;  
        #endregion



        #endregion

        #region [- TypeSafety -]
        //Describe TypeSafety in C# <== C# is Strongly typed
        //javascript is not strongly typed ==> javascript is not TypeSafe
        // C# is Strongly typed ==> C# is  TypeSafe 
        #endregion

        #region [- Casting -]
        //implicit --> when we don't have loosing data
        //explicit --> when we  have loosing data

        #endregion

        #endregion


        #region [- Chapter 9 -]

        #region [- Collections -]
        //Array
        //Collection
        //List 
        //Setting Capacity for List:
        //Capacity: List<string> _comments=new List<string>(capacity:10);
        //Ensure Capacity: 
        //listObject.EnsureCapacity(20); //Addup capacity
        //.Remove()
        //.RemoveAll(c=>c.startswith("a"))
        //.RemoveAt(12) --> remove 12th element of the list
        //.RemoveRange(2,4) --> remove 4 items starts  from 2th element
        //.Clear() --> empty list completely
        //.Insert(5,"A") --> Insert "A" in the 5th element
        //.Find(c=>c.startswith("a"))
        //.FindAll(c=>c.startswith("a")),...
        //.FindLast() ,...

        //IReadOnlyList
        //LinkedList
        //SortedList<Key,Value>
        //Dictionary == HashTable == Map == Key value pair list
        //SortedDictionary ==> Very good for performance

        //Set ==> Collections with unique values
        //SortedSet
        //HashSet
        //DataSet in Ado.net

        //Immutable Collections
        #endregion

        //Bug vs. UserError vs. Exception
        //Intrinsic Public Exception Handler for .net 
        //in c#6:
        //Chatch filtering with "when"
        #endregion

        #region [- Chapter 10 : LINQ -]
        //Query base
        //Method base --> better
        //Deffered execution vs. Immidiate execution --> Method base is Immidiate

        #endregion
    }
}
