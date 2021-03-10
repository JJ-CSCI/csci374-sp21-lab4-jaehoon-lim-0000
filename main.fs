module Assignment

// Problem 1
let rec prod (lst:int list) =
    // write your solution here if lst.isEmpty
 if List.isEmpty lst
 then 1
 else List.head lst*prod(List.tail lst)
    


// Problem 2
let rec map f (lst:int list) =
   if List.isEmpty lst
  then []
  else (f (List.head lst))::(map f (List.tail lst)) 

    // write your solution here
    



// Problem 3
let rec odd (lst:int list) =
    // write your solution here
   if List.isEmpty lst
   then []
   else 
   let head = List.head lst
   let tail = List.tail lst 
   if head % 2 = 1
   then head::(odd tail) 
   else odd tail
   
    
// Problem 4
let rec filter f lst =
    // write your solution here
   if List.isEmpty lst 
   then []
   else
   let head = List.head lst
   let tail = List.tail lst
   if f head
   then head::(filter f tail)
   else filter f tail
