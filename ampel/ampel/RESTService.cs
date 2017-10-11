using System;
using System.Collections.Generic;
using ampel.service;
using servicehost.contract;

namespace ampel.svc
{
    [Service]
    public class RESTService
    {
        [EntryPoint(HttpMethods.Post, "/subscriptions")]
        public string AddSubscription([Payload] Subscription subscription) {
            if (subscription == null) return "No payload";
            // TODO: has to return the id of the new subscription
            return $"{subscription.Name}, {subscription.Firstname}, {subscription.Email}, {subscription.Tag}";
        }

        [EntryPoint(HttpMethods.Delete, "/subscriptions/{id}")]
        public string DeleteSubscription(string id) {
            // TODO: has to return result indicating ok or error
            return "Ok";
        }

        [EntryPoint(HttpMethods.Post, "/subscriptions/{id}/ratings")]
        public string AddRating(string id, [Payload] Rating rating) {
            if (rating == null) return "No payload";
            // TODO: has to return result indicating ok or error
            return "Ok";
        }

        [EntryPoint(HttpMethods.Get, "/subscriptions/{id}/ratings")]
        public List<Rating> GetRatings(string id) {
            return new List<Rating>();
        }

        [EntryPoint(HttpMethods.Post, "/subscriptions/{id}/pause")]
        public string Pause(string id, DateTime pausedUntil) {
            // TODO: has to return result indicating ok or error
            return "Ok";
        }

        [EntryPoint(HttpMethods.Post, "/subscriptions/{id}/resume")]
        public string Pause(string id) {
            // TODO: has to return result indicating ok or error
            return "Ok";
        }

        [EntryPoint(HttpMethods.Post, "/subscriptions/{id}/state")]
        public string ChangeState(string id, DateTime pausedUntil) {
            // TODO: has to return result indicating ok or error
            return "Ok";
        }

        [EntryPoint(HttpMethods.Get, "/subscriptions")]
        public string GetSubscription(string tag) {
            return "csv file content...";
        }
    }
}