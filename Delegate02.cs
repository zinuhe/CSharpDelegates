//http://kirillosenkov.blogspot.com/2007/12/delegates-as-alternative-to-single.html
//OLD Solution

/*
interface ISupportsAdd<T>
{
    void Add(T item);
}

void OldAdd<T>(ISupportsAdd<T> collectionToFill)
{
    collectionToFill.Add(item1);
    // ...
    collectionToFill.Add(item100);
}
*/

//NEW solution - delegates
//it is enough to use the System.Action<T> delegate. Compare the old way and the new way:

void NewAdd(System.Action<T> addMethod)
{
    addMethod(item1);
    // ...
    addMethod(item100);
}


// The target collection can be anything that has an "Add" method
// (which can even be named differently)
List<int> resultsToFill = new List<int>();

// Don't pass the entire collection 
// when you are only going to use 
// the Add method anyway!
// Only pass the Add method itself:
NewAdd(resultsToFill.Add);


//More examples
//https://docs.microsoft.com/en-us/archive/blogs/kirillosenkov/using-delegates-a-simple-sample
