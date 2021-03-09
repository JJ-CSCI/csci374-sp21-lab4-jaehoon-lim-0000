module Assignment

// Problem 1
let rec prod (lst:int list) =
    // write your solution here if lst.isEmpty
 if List.isEmpty lst
 then 1
 else List.head lst*prod(List.tail lst)
    


// Problem 2
let rec map f (lst:int list) =
   []
    // write your solution here
    



// Problem 3
let rec odd (lst:int list) =
    // write your solution here
   if List.head lst % 2 = 1
   then lst
   else odd(List.tail lst)
   
    
// Problem 4
let rec filter f lst =
    // write your solution here
    
    if (f > 3)
    then f :: List.head lst
              
    else filter(List.tail lst)
