﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genius.NET.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ContentRetriever.AuthorizationToken = "ldslsxMqENSqAk5u1xExamNhiKVRv_IaVz_xQU2q--QYdhi-jlxGZ9LAM0Pvyffe";
            ContentPoster.AuthorizationToken = "ldslsxMqENSqAk5u1xExamNhiKVRv_IaVz_xQU2q--QYdhi-jlxGZ9LAM0Pvyffe";
            ContentRetriever.GetAccountInfo();
            //ContentRetriever.GetAnnotationbyId("10225840");
            //ContentRetriever.GetReferentsbySongId("12");

            //ContentRetriever.GetArtistById("16775");
            //ContentRetriever.GetSongsbyArtist("16775");
            //ContentRetriever.GetWebPagebyUrl("https://docs.genius.com");
            Search.AuthenticationToken = "ldslsxMqENSqAk5u1xExamNhiKVRv_IaVz_xQU2q--QYdhi-jlxGZ9LAM0Pvyffe";
            Search.SearchTerm = "Sia";
            ContentPoster.CreateorUpdateAnnotation(true, "**hello**", "http://seejohncode.com/2014/01/27/vim-commands-piping/", "execute commands",
                "You may know that you can", "from inside of vim, with a vim command:", title: "Secret of Mana");
            //Search.DoSearch();
            /*
            try
            {
                var song = ContentRetriever.GetSongbyId("378195");
                Console.WriteLine(song.Result);
            }
            catch (AggregateException e)
            {
                Debug.WriteLine(e);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            */
            Console.ReadLine();
        }
    }
}
