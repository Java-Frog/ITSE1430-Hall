//Movie library to catalog a movie collection
//TODO: Get Movie Data
//--title, genre, descrip, mpaa rating
//--length, release year, budget
//--IsBlackAndWhite
//TODO: Operations Add, edit, view, delete


string title = "", genre = "", description = "", rating = "", input;
int length = 0, releaseYear = 1900;
decimal budget=125.45M;
bool isBlackAndWhite=false;

Console.WriteLine("Enter a title: ");
input = Console.ReadLine();
title = input;

Console.WriteLine("Enter a description: ");
input = Console.ReadLine();
description = input;

//TODO: Convert to into
//Console.WriteLine("Enter the run length (in minutes): ");
//input = Console.ReadLine();
//title = input;

Console.WriteLine(title);
Console.WriteLine(description);
Console.WriteLine(length);