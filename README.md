# LabTask11
Lab Task 11 – Introducing Generics

1. Intergenic Research Library provides extensive collection of books to the students of
Genic University. The Research Library becomes an important exploring tool around
for all the current students who hold the University IDs.
The books in Intergenic Research Library are mainly categorized into the following:
 Archaeological
 World Music and Poetry
 Art
 Historical Collections
 Medical Science, Population Science, Environmental Science
 Teaching and Learning
 Photography
 Film and Theatre
 Law
The library is open during weekdays from 9-5 pm and is closed on weekends.
However, if there is any examination that is fast approaching, the library will be open
on special request. The events in the library are updated every weekend. The deadlines
for closing all the accounts in the library are at the end of the corresponding academic
year.
Since the university has its population increasing year by year, the librarian requests to
prepare software that will help the library staff to settle the accounts.
Therefore, the IT team of the university thus decides to help the librarian by creating
software that uses the concepts of Generics. The details that were given to the software
team are as follows:

a) Name of the student
b) Year of study
c) The book that the student has taken:
 Name of the book
 ID of the book
d) The date on which the book was issued
e) The date on which the book is to be returned
f) Name of the students who haven’t returned the book
 Name of the book that was not written along with the ID of the book
Hence, use the idea of interface IDefaulterList to declare methods in C#:
a) GetName(): To get the name of the student.
b) GetYear(): To display the year in which the student is working.
c) GetBook(): To get the details of the name and ID of the book.
d) GetDateIssue(): To display the date when the book was issued.
e) GetDateReturn(): To display the date when the book is supposed to be issued.
f) GetDefaulter(): To get the names of all the students who haven’t returned the
book. This method should also include the name and ID of the book that was not
returned.
Now, create a class Library that will implement the interface IDefaulterList. Create a
generic class GenericDefaulterList with the type parameter applied on the interface
IDefaulterList.
Finally, create a main method in the class UniversityLibrary that will in turn create an
instance for the class GenericDefaulterList that has its type parameter value as
Library, since the class Library implements the interface IDefaulterList.
Display the required details in an orderly manner using format specifiers. Ensure that
the date displayed is in appropriate date format.

=============================SUBMISSION==============================
Please note serious attention is now being drawn to the originality of every task
submitted. As it is generally believe that no two persons can reason exactly the way,
picking the same variable names, implementing logic exactly the same way etc.
Therefore, each student is expected to submit only his/her own authentic work.
