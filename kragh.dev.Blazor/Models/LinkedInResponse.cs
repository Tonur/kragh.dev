// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

#nullable disable

namespace kragh.dev.Blazor.Models
{
	public class AccomplishmentCours
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("number")]
		public string Number { get; set; }
	}

	public class AccomplishmentHonorsAward
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("issued_on")]
		public DateTime IssuedOn { get; set; }

		[JsonProperty("issuer")]
		public string Issuer { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }
	}

	public class AccomplishmentOrganisation
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("ends_at")]
		public object EndsAt { get; set; }

		[JsonProperty("org_name")]
		public string OrgName { get; set; }

		[JsonProperty("starts_at")]
		public DateTime StartsAt { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }
	}

	public class AccomplishmentPatent
	{
		[JsonProperty("application_number")]
		public string ApplicationNumber { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("issued_on")]
		public DateTime IssuedOn { get; set; }

		[JsonProperty("issuer")]
		public string Issuer { get; set; }

		[JsonProperty("patent_number")]
		public string PatentNumber { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class AccomplishmentProject
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("ends_at")]
		public DateTime? EndsAt { get; set; }

		[JsonProperty("starts_at")]
		public DateTime StartsAt { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class AccomplishmentPublication
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("published_on")]
		public DateTime PublishedOn { get; set; }

		[JsonProperty("publisher")]
		public string Publisher { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class AccomplishmentTestScore
	{
		[JsonProperty("date_on")]
		public DateTime DateOn { get; set; }

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
		public string Link { get; set; }

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
		public DateTime? EndsAt { get; set; }

		[JsonProperty("license_number")]
		public string LicenseNumber { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("starts_at")]
		public DateTime StartsAt { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class Education
	{
		[JsonProperty("degree_name")]
		public string DegreeName { get; set; }

		[JsonProperty("description")]
		public object Description { get; set; }

		[JsonProperty("ends_at")]
		public DateTime? EndsAt { get; set; }

		[JsonProperty("field_of_study")]
		public string FieldOfStudy { get; set; }

		[JsonProperty("logo_url")]
		public string LogoUrl { get; set; }

		[JsonProperty("school")]
		public string School { get; set; }

		[JsonProperty("starts_at")]
		public DateTime StartsAt { get; set; }
	}

	public class Experience
	{
		[JsonProperty("company")]
		public string Company { get; set; }

		[JsonProperty("company_linkedin_profile_url")]
		public string CompanyLinkedInProfileUrl { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("ends_at")]
		public DateTime? EndsAt { get; set; }

		[JsonProperty("location")]
		public string Location { get; set; }

		[JsonProperty("logo_url")]
		public string LogoUrl { get; set; }

		[JsonProperty("starts_at")]
		public DateTime StartsAt { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }
	}

	public class PeopleAlsoViewed
	{
		[JsonProperty("link")]
		public string Link { get; set; }

		[JsonProperty("location")]
		public string Location { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("summary")]
		public string Summary { get; set; }
	}

	public class SimilarlyNamedProfile
	{
		[JsonProperty("link")]
		public string Link { get; set; }

		[JsonProperty("location")]
		public string Location { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("summary")]
		public string Summary { get; set; }
	}

	public class VolunteerWork
	{
		[JsonProperty("cause")]
		public string Cause { get; set; }

		[JsonProperty("company")]
		public string Company { get; set; }

		[JsonProperty("company_linkedin_profile_url")]
		public object CompanyLinkedInProfileUrl { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("ends_at")]
		public DateTime? EndsAt { get; set; }

		[JsonProperty("logo_url")]
		public string LogoUrl { get; set; }

		[JsonProperty("starts_at")]
		public DateTime StartsAt { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }
	}

	public class LinkedInResponse
	{
		[JsonProperty("accomplishment_courses")]
		public List<AccomplishmentCours> AccomplishmentCourses { get; set; }

		[JsonProperty("accomplishment_honors_awards")]
		public List<AccomplishmentHonorsAward> AccomplishmentHonorsAwards { get; set; }

		[JsonProperty("accomplishment_organisations")]
		public List<AccomplishmentOrganisation> AccomplishmentOrganisations { get; set; }

		[JsonProperty("accomplishment_patents")]
		public List<AccomplishmentPatent> AccomplishmentPatents { get; set; }

		[JsonProperty("accomplishment_projects")]
		public List<AccomplishmentProject> AccomplishmentProjects { get; set; }

		[JsonProperty("accomplishment_publications")]
		public List<AccomplishmentPublication> AccomplishmentPublications { get; set; }

		[JsonProperty("accomplishment_test_scores")]
		public List<AccomplishmentTestScore> AccomplishmentTestScores { get; set; }

		[JsonProperty("activities")]
		public List<Activity> Activities { get; set; }

		[JsonProperty("articles")]
		public List<object> Articles { get; set; }

		[JsonProperty("background_cover_image_url")]
		public string BackgroundCoverImageUrl { get; set; }

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

		[JsonProperty("profile_pic_url")]
		public string ProfilePicUrl { get; set; }

		[JsonProperty("public_identifier")]
		public string PublicIdentifier { get; set; }

		[JsonProperty("recommendations")]
		public List<object> Recommendations { get; set; }

		[JsonProperty("similarly_named_profiles")]
		public List<SimilarlyNamedProfile> SimilarlyNamedProfiles { get; set; }

		[JsonProperty("state")]
		public object State { get; set; }

		[JsonProperty("summary")]
		public string Summary { get; set; }

		[JsonProperty("volunteer_work")]
		public List<VolunteerWork> VolunteerWork { get; set; }
	}
}