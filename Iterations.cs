using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {
        /*
           Welcome to Interation
           Down below you will find instructions for code to write.
           As you write and save your code, you can look in your terminal where you
           ran `dotnet watch test` to see if your code is working. The tests continuously check
           your work each time you save. If a test is failing you have not yet completed that method
           Once you finish a method and have it correct, the test will tell you how
           the next method is working.
        */


        //  
        // 1) Complete the method named `yelling` that takes an list of
        //    words as an argument and returns a new list with all
        //    the words forced to uppercase.
        //
        public static IEnumerable<string> Yelling(List<string> words)
        {
            var uppercasedWords = words.Select(word => word.ToUpper());
            return uppercasedWords;
        }


        // 
        // 2) Complete the method named `Double` that takes an list of
        //    numbers as an argument and returns a new list with all
        //    the numbers multiplied by 2.
        // 
        public static IEnumerable<int> Double(List<int> numbers)
        {
            var doubledNumbers = numbers.Select(number => number * 2);
            return doubledNumbers;
        }


        // 
        // 3) Complete the method `StringyIndexes` that takes an list of
        //    strings as an argument and returns a new list with each
        //    string suffixed with " is at index X" where X is the index
        //    of the element.
        // 
        public static IEnumerable<string> StringyIndexes(List<string> data)
        {
            var newListOfStringsAndIndexes = data.Select((stringy, index) => $"{stringy} is at index {index}");
            return newListOfStringsAndIndexes;
        }


        // 
        // 4) Complete the method OnlyTheEvenSurvive that accepts an list of
        //    numbers and returns only the elements that are even.
        // 
        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> data)
        {
            var evensOnly = data.Where(number => number % 2 == 0);
            return evensOnly;
        }


        // 
        // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts an
        //    list of numbers and returns only the elements at indexes that
        //    are even.
        // 
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> data)
        {
            var evensAtIndexes = data.Where((number, index) => index % 2 == 0);
            return evensAtIndexes;

        }


        // 
        // 6) Complete the method BestMoviesOfTheYear that accepts an list of
        //    movie objects AND a year and returns the names of movies that are
        //    from that year AND have a score more than 90.
        // 
        // A movie object looks like this:
        // 
        // {
        //   name: "Get Out",
        //   year: "2017",
        //   score: 99
        // }
        // 
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> data, int year)
        {
            var startMoviesFrom2017 = data.Where(movie => movie.Year == year && movie.Score > 90);
            var goodMoviesFrom2017 = startMoviesFrom2017.Select(movie => movie.Name);
            return goodMoviesFrom2017;
        }


        // 
        // 7) Complete the method EveryoneIsOdd that accepts an list of
        //    numbers and returns true if every element of the list is odd.
        // 
        public static bool EveryoneIsOdd(List<int> data)
        {
            var oddsOnly = data.All(odds => odds % 2 != 0);
            return oddsOnly;
        }


        // 
        // 8) Complete the method FindTheNeedle that accepts a list of
        //    strings and returns the one string that contains the word
        //    `needle`.
        // 
        public static string FindTheNeedle(List<string> data)
        {
            var needleFound = data.FirstOrDefault(data => data.Contains("needle"));
            return needleFound;

        }


        // 
        // 9) Complete the method FindTheNeedleIndex that accepts an list of
        //    strings and returns the index of the string that contains
        //    the word `needle` inside.
        // 
        public static int FindTheNeedleIndex(List<string> data)
        {
            var needleFoundIndex = data.FindIndex(data => data.Contains("needle"));
            return needleFoundIndex;

        }


        // 
        // 10) Complete the method SomeoneToLove that accepts an list of
        //     strings and returns true if at least one string is exactly
        //     four characters long.
        // 
        public static bool SomeoneToLove(List<string> data)
        {
            var fourCharactersLong = data.Any(data => data.Length == 4);
            return fourCharactersLong;
        }
    }
}