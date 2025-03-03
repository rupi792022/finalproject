﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Tweetinvi;
using finalproject.Models;

namespace finalproject.Controllers
{
    public class TwittersController : ApiController
    {

        // GET api/<controller>
        [HttpGet]
        [Route("api/Twitters/getTweet")]
        public async Task<Twitter> getTweet(long tweetid, string email)
        {
            Twitter t = new Twitter();
            return await t.getTweet(tweetid, email);
        }

        [HttpPost]
        [Route("api/Twitters/UpdateStatus")]
        public void UpdateStatus( List<Twitter> notRe_tweets)
        {
            Twitter t = new Twitter();
            t.UpdateStatus(notRe_tweets);
        }

        [HttpGet]
        [Route("api/Twitters/getTweetsNotRe")]
        public List<Twitter> getTweetsNotRe()
        {
            Twitter t = new Twitter();
            return t.getTweetsNotRe();
        }

        [HttpGet]
        [Route("api/Twitters/getTweets")]
        public List<Twitter> getTweets()
        {
            Twitter t = new Twitter();
            return t.getTweets();
        }

        [HttpGet]
        [Route("api/Twitters/getHashtag")]
        public Dictionary<string, int> getHashtag()
        {
            Twitter t = new Twitter();
            return t.getHashtag();
        }

        [HttpGet]
        [Route("api/Twitters/getCommonUsers")]
        public Dictionary<string, int> getCommonUsers()
        {
            Twitter t = new Twitter();
            return t.getCommonUsers();
        }
        // PUT api/<controller>/5

        [HttpPost]
        [Route("api/Twitters")]
        public bool Post([FromBody] Twitter twitter)
        {
           return twitter.InsertTweet();
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}