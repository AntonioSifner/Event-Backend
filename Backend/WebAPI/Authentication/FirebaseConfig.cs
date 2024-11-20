using Firebase.Auth;
using Firebase.Auth.Providers;
using Google.Cloud.Firestore;

namespace WebAPI.Authentication
{
    public static class FirebaseConfig
    {
        public static readonly FirebaseAuthConfig AuthConfig = new()
        {
            ApiKey = "AIzaSyA4VuNOdalUSa15p_5LcSJW5f2hdgwcyH0",
            AuthDomain = "eventepicenter-cd6ea.firebaseapp.com",
            Providers = new FirebaseAuthProvider[]
            {
                new EmailProvider()
            },
        };

        public static readonly FirestoreDb database = FirestoreDb.Create("eventepicenter-cd6ea");
    }
}
