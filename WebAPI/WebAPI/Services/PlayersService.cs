﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.ViewModels;

namespace WebAPI.Services
{
    public class PlayersService
    {
        private AppDbContext _context;

        public PlayersService(AppDbContext context)
        {
            _context = context;
        }

        public List<PlayerVM> GetPlayers()
        {
            var playerVMs = new List<PlayerVM>();

            var players = _context.Players.ToList();
            foreach (var player in players)
            {
                PlayerVM playerVM = new PlayerVM();
                playerVM.PCode = player.PCode;
                playerVM.Name = player.Name;
                playerVM.Surname = player.Surname;
                playerVM.DOB = player.DOB;
                playerVM.Height = player.Height;
                playerVM.CountryCode2 = player.CountryCode.Code2;
                playerVM.CountryCode3 = player.CountryCode.Code3;
                playerVM.CountryName = player.CountryCode.Name;


                var playerInfoVMs = new List<PlayerInfoVM>();
                foreach (var playerInfo in player.PlayerInfo)
                {
                    var playerInfoVM = new PlayerInfoVM();

                    playerInfoVM.uPER = playerInfo.uPER;
                    playerInfoVM.aPER = playerInfo.aPER;
                    playerInfoVM.PER = playerInfo.PER;
                    playerInfoVM.GamesPlayed = playerInfo.GamesPlayed;
                    playerInfoVM.Number = playerInfo.Number;
                    playerInfoVM.Position = playerInfo.Position;
                    playerInfoVM.Status = playerInfo.Status;
                    playerInfoVM.Club = playerInfo.Club.Name;
                    playerInfoVM.ClubId = playerInfo.Club.Id;

                    playerInfoVMs.Add(playerInfoVM);
                }

                playerVMs.Add(playerVM);
            }

            return playerVMs;
        }

        public PlayerVM GetPlayerById(Guid id)
        {
            PlayerVM playerVM = new PlayerVM();

            var player = _context.Players.FirstOrDefault(player => player.Id == id);
            if (player != null)
            {
                playerVM.PCode = player.PCode;
                playerVM.Name = player.Name;
                playerVM.Surname = player.Surname;
                playerVM.DOB = player.DOB;
                playerVM.Height = player.Height;
                playerVM.CountryCode2 = player.CountryCode.Code2;
                playerVM.CountryCode3 = player.CountryCode.Code3;
                playerVM.CountryName = player.CountryCode.Name;

                var playerInfoVMs = new List<PlayerInfoVM>();
                foreach (var playerInfo in player.PlayerInfo)
                {
                    var playerInfoVM = new PlayerInfoVM();

                    playerInfoVM.uPER = playerInfo.uPER;
                    playerInfoVM.aPER = playerInfo.aPER;
                    playerInfoVM.PER = playerInfo.PER;
                    playerInfoVM.GamesPlayed = playerInfo.GamesPlayed;
                    playerInfoVM.Number = playerInfo.Number;
                    playerInfoVM.Position = playerInfo.Position;
                    playerInfoVM.Status = playerInfo.Status;
                    playerInfoVM.Club = playerInfo.Club.Name;
                    playerInfoVM.ClubId = playerInfo.Club.Id;

                    playerInfoVMs.Add(playerInfoVM);
                }
            }

            return playerVM;
        }

        public PlayerVM GetPlayerByPlayerCode(string code)
        {
            PlayerVM playerVM = new PlayerVM();

            var player = _context.Players.FirstOrDefault(player => player.PCode == code);
            if (player != null)
            {
                playerVM.PCode = player.PCode;
                playerVM.Name = player.Name;
                playerVM.Surname = player.Surname;
                playerVM.DOB = player.DOB;
                playerVM.Height = player.Height;
                playerVM.CountryCode2 = player.CountryCode.Code2;
                playerVM.CountryCode3 = player.CountryCode.Code3;
                playerVM.CountryName = player.CountryCode.Name;

                var playerInfoVMs = new List<PlayerInfoVM>();
                foreach (var playerInfo in player.PlayerInfo)
                {
                    var playerInfoVM = new PlayerInfoVM();

                    playerInfoVM.uPER = playerInfo.uPER;
                    playerInfoVM.aPER = playerInfo.aPER;
                    playerInfoVM.PER = playerInfo.PER;
                    playerInfoVM.GamesPlayed = playerInfo.GamesPlayed;
                    playerInfoVM.Number = playerInfo.Number;
                    playerInfoVM.Position = playerInfo.Position;
                    playerInfoVM.Status = playerInfo.Status;
                    playerInfoVM.Club = playerInfo.Club.Name;
                    playerInfoVM.ClubId = playerInfo.Club.Id;

                    playerInfoVMs.Add(playerInfoVM);
                }
            }

            return playerVM;
        }

        public PlayerVM GetPlayerByPlayerName(string name)
        {
            PlayerVM playerVM = new PlayerVM();

            var player = _context.Players.FirstOrDefault(player => player.Name == name);
            if (player != null)
            {
                playerVM.PCode = player.PCode;
                playerVM.Name = player.Name;
                playerVM.Surname = player.Surname;
                playerVM.DOB = player.DOB;
                playerVM.Height = player.Height;
                playerVM.CountryCode2 = player.CountryCode.Code2;
                playerVM.CountryCode3 = player.CountryCode.Code3;
                playerVM.CountryName = player.CountryCode.Name;

                var playerInfoVMs = new List<PlayerInfoVM>();
                foreach (var playerInfo in player.PlayerInfo)
                {
                    var playerInfoVM = new PlayerInfoVM();

                    playerInfoVM.uPER = playerInfo.uPER;
                    playerInfoVM.aPER = playerInfo.aPER;
                    playerInfoVM.PER = playerInfo.PER;
                    playerInfoVM.GamesPlayed = playerInfo.GamesPlayed;
                    playerInfoVM.Number = playerInfo.Number;
                    playerInfoVM.Position = playerInfo.Position;
                    playerInfoVM.Status = playerInfo.Status;
                    playerInfoVM.Club = playerInfo.Club.Name;
                    playerInfoVM.ClubId = playerInfo.Club.Id;

                    playerInfoVMs.Add(playerInfoVM);
                }
            }

            return playerVM;
        }

        public PlayerVM GetPlayerByPlayerSurname(string surname)
        {
            PlayerVM playerVM = new PlayerVM();

            var player = _context.Players.FirstOrDefault(player => player.Surname == surname);
            if (player != null)
            {
                playerVM.PCode = player.PCode;
                playerVM.Name = player.Name;
                playerVM.Surname = player.Surname;
                playerVM.DOB = player.DOB;
                playerVM.Height = player.Height;
                playerVM.CountryCode2 = player.CountryCode.Code2;
                playerVM.CountryCode3 = player.CountryCode.Code3;
                playerVM.CountryName = player.CountryCode.Name;

                var playerInfoVMs = new List<PlayerInfoVM>();
                foreach (var playerInfo in player.PlayerInfo)
                {
                    var playerInfoVM = new PlayerInfoVM();

                    playerInfoVM.uPER = playerInfo.uPER;
                    playerInfoVM.aPER = playerInfo.aPER;
                    playerInfoVM.PER = playerInfo.PER;
                    playerInfoVM.GamesPlayed = playerInfo.GamesPlayed;
                    playerInfoVM.Number = playerInfo.Number;
                    playerInfoVM.Position = playerInfo.Position;
                    playerInfoVM.Status = playerInfo.Status;
                    playerInfoVM.Club = playerInfo.Club.Name;
                    playerInfoVM.ClubId = playerInfo.Club.Id;

                    playerInfoVMs.Add(playerInfoVM);
                }
            }

            return playerVM;
        }
    }
}
