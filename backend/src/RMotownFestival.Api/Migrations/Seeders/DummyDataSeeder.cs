﻿using System;

using Microsoft.EntityFrameworkCore;

using RMotownFestival.Api.Domain;

namespace RMotownFestival.Api.Migrations.Seeders
{
    public static class DummyDataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var description = "A music festival is a festival oriented towards music that is sometimes presented with a theme such as musical genre, nationality or locality of musicians, or holiday. They are commonly held outdoors, and are often inclusive of other attractions such as food and merchandise vending machines, performance art, and social activities. Large music festivals such as Lollapalooza are constructed around well known main stage acts and lesser known musicians and bands on side stages. Many festivals are annual, or repeat at some other interval, and have modular staging of many types. Each year Lollapalooza often features multiple acts on its main and side stages.";
            var stages = new[] {
                new Stage { Id = 1, Name = "Main Stage", Description = description },
                new Stage { Id = 2, Name = "Orange Room", Description = description },
                new Stage { Id = 3, Name = "StarDust", Description = description },
                new Stage { Id = 4, Name = "Pink Room", Description = description }
            };
            modelBuilder.Entity<Stage>().HasData(stages);

            var artists = new[] {
                new Artist { Id = 1, Name = "Diana Ross", ImagePath = "dianaross.jpg", Website = new Uri("http://www.dianaross.co.uk/indexb.html") },
                new Artist { Id = 2, Name = "The Commodores", ImagePath = "thecommodores.jpg", Website = new Uri("http://en.wikipedia.org/wiki/Commodores") },
                new Artist { Id = 3, Name = "Stevie Wonder", ImagePath = "steviewonder.jpg", Website = new Uri("http://www.steviewonder.net/") },
                new Artist { Id = 4, Name = "Lionel Richie", ImagePath = "lionelrichie.jpg", Website = new Uri("http://lionelrichie.com/") },
                new Artist { Id = 5, Name = "Marvin Gaye", ImagePath = "marvingaye.jpg", Website = new Uri("http://www.marvingayepage.net/") }
            };
            modelBuilder.Entity<Artist>().HasData(artists);

            var schedules = new[] {
                new Schedule { Id = 1 }
            };
            modelBuilder.Entity<Schedule>().HasData(schedules);

            var scheduleItems = new[] {
                new ScheduleItem { Id = 1, ScheduleId = 1, ArtistId = 1, StageId = 1, Time = new DateTime(1972, 07, 01, 20, 0, 0) },
                new ScheduleItem { Id = 2, ScheduleId = 1, ArtistId = 5, StageId = 4, Time = new DateTime(1972, 07, 01, 20, 30, 0) },
                new ScheduleItem { Id = 3, ScheduleId = 1, ArtistId = 3, StageId = 1, Time = new DateTime(1972, 07, 01, 22, 0, 0) },
                new ScheduleItem { Id = 4, ScheduleId = 1, ArtistId = 2, StageId = 2, Time = new DateTime(1972, 07, 01, 22, 15, 0) },
                new ScheduleItem { Id = 5, ScheduleId = 1, ArtistId = 1, StageId = 1, Time = new DateTime(1972, 07, 02, 20, 15, 0) },
                new ScheduleItem { Id = 6, ScheduleId = 1, ArtistId = 5, StageId = 4, Time = new DateTime(1972, 07, 02, 20, 45, 0) },
                new ScheduleItem { Id = 7, ScheduleId = 1, ArtistId = 4, StageId = 1, Time = new DateTime(1972, 07, 02, 22, 0, 0) },
                new ScheduleItem { Id = 8, ScheduleId = 1, ArtistId = 2, StageId = 2, Time = new DateTime(1972, 07, 02, 22, 30, 0) }
            };
            modelBuilder.Entity<ScheduleItem>().HasData(scheduleItems);

            var festivals = new[] {
                new Festival { Id = 1, LineUpId = 1 }
            };
            modelBuilder.Entity<Festival>().HasData(festivals);
        }
    }
}
