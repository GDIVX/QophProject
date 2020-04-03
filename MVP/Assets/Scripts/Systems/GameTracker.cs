using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTracker : MonoBehaviour
{
    public static GameTracker instance;

    public bool isGameInSession = true;
    public int teamsAmmount;
    public float waitToEndTimer;
    public Team[] teams;
    public Quest activeQuest;

    int SpaceInTeams = 1;

    public Action<Team> OnWin_CallBack;
    public Action<Team> OnLoose_CallBack;

    public Action<Quest> OnQuestComplete_CallBack;
    public Action<Quest> OnQuestIncompletable_callBack;

    GameObject[] players;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        CreateTeams();
    }

    private void Update()
    {
        activeQuest.QuestCallback();
    }
    private void CreateTeams()
    {
        teams = new Team[teamsAmmount];
        for (int i = 0; i < teamsAmmount; i++)
        {
            Team teamI = new Team(i);
            teams[i] = teamI;
        }
    }

    public void Win(Team team)
    {
        if (!isGameInSession)
        {
            return;
        }
        isGameInSession = false;
        float count = 0;


        while (count <= waitToEndTimer)
        {
            count++;
        }
        if (OnWin_CallBack != null)
        {
            OnWin_CallBack(team);
            if (OnLoose_CallBack != null)
            {
                foreach (Team t in teams)
                {
                    if (t == team)
                    {
                        continue;
                    }
                    OnLoose_CallBack(t);
                }
            }
        }
    }


    public void CompleteQuest(Quest quest, Team team)
    {
        if (quest.goal.GetGoalValidity())
        {
            if (OnQuestComplete_CallBack != null)
            {
                OnQuestComplete_CallBack(quest);
                Win(team);
            }
        }
        else
        {
            if (OnQuestIncompletable_callBack != null)
            {
                OnQuestIncompletable_callBack(quest);
            }
        }
    }

    public bool CanJoinTeam(Team team)
    {
        return team.members.Count < SpaceInTeams;
    }

    public void MakeSpaceInTeams()
    {
        SpaceInTeams++;
    }
}
