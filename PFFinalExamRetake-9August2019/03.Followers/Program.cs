using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _03.Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<int>> followersAndLikesAndComments = new Dictionary<string, List<int>>();
            while ((input = Console.ReadLine()) != "Log out")
            {
                string[] splittedInput = input.Split(":");
                string command = splittedInput[0];
                string follower = splittedInput[1];
                if (command == "New follower")
                {
                    if (!followersAndLikesAndComments.ContainsKey(follower))
                    {
                        followersAndLikesAndComments.Add(follower, new List<int>() { 0, 0 });
                    }
                }
                else if (command == "Like")
                {
                    int countOfLikes = int.Parse(splittedInput[2]);
                    if (followersAndLikesAndComments.ContainsKey(follower))
                    {
                        followersAndLikesAndComments[follower][0] += countOfLikes;
                    }
                    else
                    {
                        followersAndLikesAndComments.Add(follower, new List<int>() {countOfLikes, 0});
                    }
                }
                else if (command == "Comment")
                {

                    if (followersAndLikesAndComments.ContainsKey(follower))
                    {
                        followersAndLikesAndComments[follower][1] += 1;
                    }
                    else
                    {
                        followersAndLikesAndComments.Add(follower, new List<int>() {0, 1});
                    }
                }
                else if (command == "Blocked")
                {
                    if (!followersAndLikesAndComments.ContainsKey(follower))
                    {
                        Console.WriteLine($"{follower} doesn't exist.");
                    }
                    else
                    {
                        followersAndLikesAndComments.Remove(follower);
                    }
                }
            }

            Console.WriteLine($"{followersAndLikesAndComments.Keys.Count} followers");
            followersAndLikesAndComments = followersAndLikesAndComments.OrderByDescending(f => f.Value[0]).ThenBy(f => f.Key).ToDictionary(f => f.Key, f => f.Value);
            foreach (var item in followersAndLikesAndComments)
            {
                Console.WriteLine($"{item.Key}: {item.Value[0] + item.Value[1]}");
            }

        }
    }
}
