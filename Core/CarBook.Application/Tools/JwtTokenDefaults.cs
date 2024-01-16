namespace CarBook.Application.Tools
{
	public class JwtTokenDefaults
	{
		public const string ValidAudience = "https://localhost";
		public const string ValidIssuer = "https://localhost";
		public const string IssuerSigningKey = "carbookcarbook01";
		public const int Expire = 3;
	}
}
