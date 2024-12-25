﻿namespace FirstAPI.Entities;

public class Game
{
    public int Id { get; set; }
    public int BannedWordCount { get; set; }
    public int FailCount { get; set; }
    public int SkipCount { get; set; }
    public TimeSpan Time { get; set; }
    public int Score { get; set; }
    public int SuccesAnswer { get; set; }
    public int WrongAnswer { get; set; }
    public string LanguageCode { get; set; }
    public Language Language { get; set; } = null!;
}
