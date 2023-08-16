using System;
using System.Collections;

namespace VotingSystem
{
    class Program
    {
        static Dictionary<string, int> categoryVotes = new Dictionary<string, int>();
        static List<string> categories = new List<string> { "Movies/Series", "Technology", "Sport", "Art", "Music" };
        static HashSet<string> registeredUsers = new HashSet<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Voting System!");

            while (true)
            {
                Console.WriteLine("\nCategories:");
                for (int i = 0; i < categories.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {categories[i]}");
                }

                Console.Write("Please select the category number you want to vote for (0 to view results): ");
                int selectedCategoryIndex = int.Parse(Console.ReadLine());

                if (selectedCategoryIndex == 0)
                {
                    ShowVotingResults();
                }
                else if (selectedCategoryIndex >= 1 && selectedCategoryIndex <= categories.Count)
                {
                    string selectedCategory = categories[selectedCategoryIndex - 1];
                    Vote(selectedCategory);
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                }
            }
        }

        static void Vote(string category)
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            if (!registeredUsers.Contains(username))
            {
                Console.Write("Username is not registered in the system. Would you like to sign up? (Y/N): ");
                string response = Console.ReadLine();
                if (response.ToLower() == "y")
                {
                    registeredUsers.Add(username);
                    Console.WriteLine("The user has been registered and your vote has been taken.");
                    IncrementVote(category);
                }
                else if (response.ToLower() == "n")
                {
                    Console.WriteLine("Not registered. You cannot vote.");
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }
            }
            else
            {
                Console.WriteLine("Your vote has already been taken. A user can vote only once.");
            }
        }

        static void IncrementVote(string category)
        {
            if (!categoryVotes.ContainsKey(category))
            {
                categoryVotes[category] = 1;
            }
            else
            {
                categoryVotes[category]++;
            }

        }

        static void ShowVotingResults()
        {
            Console.WriteLine("\nVoting Result:");
            foreach (var category in categoryVotes.Keys)
            {
                int voteCount = categoryVotes[category];
                double percentage = (double)voteCount / registeredUsers.Count * 100;
                Console.WriteLine($"{category}: {voteCount} vote, %{percentage:F2}");
            }
        }
    }
}