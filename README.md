# Library System with Book Status Tracking

Concepts Used: Enum, Indexer, Class, List, OOP
Description:
Create an enum `BookStatus`: Available, CheckedOut, Reserved
Create a class `Book` with:
- Title, Author, Status (use the enum)
Create a class `Library` with:
- A list of books
- Indexer: library["Book Title"] → returns the `Book` object
Add methods:
- ChangeStatus(title, status)
- ShowBooksByStatus(BookStatus status)
Demonstrate:
- Adding at least 5 books
- Accessing them by title using the indexer
- Filtering books by status
