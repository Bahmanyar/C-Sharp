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
    }
}
