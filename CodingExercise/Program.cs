using Microsoft.Extensions.DependencyInjection;
using System;

namespace CodingExercise
{
    /*
    VinSolutions Coding Assessment

    In the programming language of your choice, write a program that parses a sentence and replaces each word with the following: 
    first letter, number of distinct characters between first and last character, and last letter.  For example, Smooth would become S3h.  
    Words are separated by spaces or non-alphabetic characters and these separators should be maintained in their original form and location in the answer.

    A few of the things we will be looking at is accuracy, efficiency, solution completeness. 
    Please include this problem description in the comment at the top of your solution.  
    The problem is designed to take approximately 1-2 hours and will be used as a conversation point in the verbal assessment part of the on-site interview.  
    Please complete the coding assessment and have your solution uploaded as soon as possible.

    Please upload your solution to Dropbox or similar option (not G-Drive) and send a link to download the folder prior to you interview. 
    */

    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = Setup();
            var sentenceProcessor = serviceProvider.GetService<ISentenceProcessor>();

            var sentence = "";
            while(sentence != "quit!")
            {
                sentence = Console.ReadLine();
                var result = sentenceProcessor.ProcessSentence(sentence);
                Console.WriteLine(result);
            }
        }

        private static IServiceProvider Setup()
        {
            var sp = new ServiceCollection()
                .AddTransient<ISentenceProcessor, SentenceProcessor>()
                .BuildServiceProvider();


            return sp;
        }
    }
}
