using _03.TeamworkProjects;

int teamsNumber = int.Parse(Console.ReadLine());

List<Team> teams = new List<Team>();

for (int i = 0; i < teamsNumber; i++)
{
    string[] createTeamInput = Console.ReadLine().Split("-");
    string teamCreator = createTeamInput[0];
    string teamName = createTeamInput[1];

    if (teams.Any(t => t.Name == teamName))
    {
        Console.WriteLine($"Team {teamName} was already created!");
    }
    else if (teams.Any(t => t.Creator == teamCreator))
    {
        Console.WriteLine($"{teamCreator} cannot create another team!");
    }
    else 
    {
        Team currentTeam = new Team(teamName, teamCreator);
        teams.Add(currentTeam);
        Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
    }      
}

string manageTeamInput = Console.ReadLine();

while(manageTeamInput != "end of assignment")
{
    string[] teamInfo = manageTeamInput.Split("->");
    string memberName = teamInfo[0];
    string teamName = teamInfo[1];

    if (teams.Any(t => t.Name == teamName) == false)
    {
        Console.WriteLine($"Team {teamName} does not exist!");
    }
    else if (teams.Any(t => t.Members.Contains(memberName) || t.Creator == memberName))
    {
        Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
    }
    else
    {
        Team teamToAddMember = teams.First(t => t.Name == teamName);
        teamToAddMember.Members.Add(memberName);
    }

    manageTeamInput = Console.ReadLine();
}

foreach(Team team in teams
    .Where(t => t.Members.Count > 0)
    .OrderByDescending(t => t.Members.Count)
    .ThenBy(t => t.Name))
{
    Console.WriteLine(team.Name);
    Console.WriteLine($"- {team.Creator}");

    foreach(string member in team.Members.OrderBy(m => m))
    {
        Console.WriteLine($"-- {member}");
    }
}

Console.WriteLine("Teams to disband:");

foreach (Team team in teams
                        .Where(t => t.Members.Count == 0)
                        .OrderBy(t => t.Name))
{
    Console.WriteLine(team.Name);
}