using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kragh.dev.Blazor.Shared
{
	public class LinkedInResponse
	{
		[JsonProperty("accomplishment_courses")]
		public List<AccomplishmentCourse> AccomplishmentCourses { get; set; }

		[JsonProperty("accomplishment_honors_awards")]
		public List<AccomplishmentHonorsAward> AccomplishmentHonorsAwards { get; set; }

		[JsonProperty("accomplishment_organisations")]
		public List<Accomplishment> AccomplishmentOrganisations { get; set; }

		[JsonProperty("accomplishment_patents")]
		public List<AccomplishmentPatent> AccomplishmentPatents { get; set; }

		[JsonProperty("accomplishment_projects")]
		public List<Accomplishment> AccomplishmentProjects { get; set; }

		[JsonProperty("accomplishment_publications")]
		public List<AccomplishmentPublication> AccomplishmentPublications { get; set; }

		[JsonProperty("accomplishment_test_scores")]
		public List<AccomplishmentTestScore> AccomplishmentTestScores { get; set; }

		[JsonProperty("activities")]
		public List<Activity> Activities { get; set; }

		[JsonProperty("articles")]
		public List<object> Articles { get; set; }

		[JsonProperty("background_cover_image_url")]
		public Uri BackgroundCoverImageUrl { get; set; }

		[JsonProperty("profile_pic_url")]
		public Uri ProfilePicUrl { get; set; }

		[JsonProperty("certifications")]
		public List<Certification> Certifications { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("connections")]
		public int Connections { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("country_full_name")]
		public string CountryFullName { get; set; }

		[JsonProperty("education")]
		public List<Education> Education { get; set; }

		[JsonProperty("experiences")]
		public List<Experience> Experiences { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("full_name")]
		public string FullName { get; set; }

		[JsonProperty("headline")]
		public string Headline { get; set; }

		[JsonProperty("languages")]
		public List<string> Languages { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("occupation")]
		public string Occupation { get; set; }

		[JsonProperty("people_also_viewed")]
		public List<PeopleAlsoViewed> PeopleAlsoViewed { get; set; }

		[JsonProperty("public_identifier")]
		public string PublicIdentifier { get; set; }

		[JsonProperty("recommendations")]
		public List<object> Recommendations { get; set; }

		[JsonProperty("similarly_named_profiles")]
		public List<PeopleAlsoViewed> SimilarlyNamedProfiles { get; set; }

		[JsonProperty("state")]
		public object State { get; set; }

		[JsonProperty("summary")]
		public string Summary { get; set; }

		[JsonProperty("volunteer_work")]
		public List<Experience> VolunteerWork { get; set; }
	}

	public class AccomplishmentCourse
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("number")]
		public int Number { get; set; }
	}

	public class AccomplishmentHonorsAward
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("issued_on")]
		public JsonDate IssuedOn { get; set; }

		[JsonProperty("issuer")]
		public string Issuer { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }
	}

	public class JsonDate
	{
		[JsonProperty("day")]
		public int Day { get; set; }

		[JsonProperty("month")]
		public int Month { get; set; }

		[JsonProperty("year")]
		public int Year { get; set; }

		public static implicit operator DateTime(JsonDate date) => new(date.Year, date.Month, date.Day);
		public static implicit operator JsonDate(DateTime date) => new() { Year = date.Year, Month = date.Month, Day = date.Day };
	}

	public class Accomplishment
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("ends_at")]
		public JsonDate EndsAt { get; set; }

		[JsonProperty("org_name", NullValueHandling = NullValueHandling.Ignore)]
		public string OrgName { get; set; }

		[JsonProperty("starts_at")]
		public JsonDate StartsAt { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
		public Uri Url { get; set; }
	}

	public class AccomplishmentPatent
	{
		[JsonProperty("application_number")]
		public int ApplicationNumber { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("issued_on")]
		public JsonDate IssuedOn { get; set; }

		[JsonProperty("issuer")]
		public string Issuer { get; set; }

		[JsonProperty("patent_number")]
		public int PatentNumber { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("url")]
		public Uri Url { get; set; }
	}

	public class AccomplishmentPublication
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("published_on")]
		public JsonDate PublishedOn { get; set; }

		[JsonProperty("publisher")]
		public string Publisher { get; set; }

		[JsonProperty("url")]
		public Uri Url { get; set; }
	}

	public class AccomplishmentTestScore
	{
		[JsonProperty("date_on")]
		public JsonDate DateOn { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("score")]
		public string Score { get; set; }
	}

	public class Activity
	{
		[JsonProperty("activity_status")]
		public string ActivityStatus { get; set; }

		[JsonProperty("link")]
		public Uri Link { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }
	}

	public class Certification
	{
		[JsonProperty("authority")]
		public string Authority { get; set; }

		[JsonProperty("display_source")]
		public string DisplaySource { get; set; }

		[JsonProperty("ends_at")]
		public JsonDate EndsAt { get; set; }

		[JsonProperty("license_number")]
		public string LicenseNumber { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("starts_at")]
		public JsonDate StartsAt { get; set; }

		[JsonProperty("url")]
		public Uri Url { get; set; }
	}

	public class Education
	{
		[JsonProperty("degree_name")]
		public string DegreeName { get; set; }

		[JsonProperty("description")]
		public object Description { get; set; }

		[JsonProperty("ends_at")]
		public JsonDate EndsAt { get; set; }

		[JsonProperty("field_of_study")]
		public string FieldOfStudy { get; set; }

		[JsonProperty("logo_url")]
		public Uri LogoUrl { get; set; }

		[JsonProperty("school")]
		public string School { get; set; }

		[JsonProperty("starts_at")]
		public JsonDate StartsAt { get; set; }
	}

	public class Experience
	{
		[JsonProperty("company")]
		public string Company { get; set; }

		[JsonProperty("company_linkedin_profile_url")]
		public Uri CompanyLinkedInProfileUrl { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("ends_at")]
		public JsonDate EndsAt { get; set; }

		[JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
		public string Location { get; set; }

		[JsonProperty("logo_url")]
		public Uri LogoUrl { get; set; }

		[JsonProperty("starts_at")]
		public JsonDate StartsAt { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("cause", NullValueHandling = NullValueHandling.Ignore)]
		public string Cause { get; set; }
	}

	public class PeopleAlsoViewed
	{
		[JsonProperty("link")]
		public Uri Link { get; set; }

		[JsonProperty("location")]
		public string Location { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("summary")]
		public string Summary { get; set; }
	}
}
