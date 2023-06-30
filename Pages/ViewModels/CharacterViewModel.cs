using System;
using RicksFriends.Domain;
using System.Collections.Generic;

namespace RicksFriends.Pages.ViewModels
{
	public class CharacterViewModel
	{
		public CharacterViewModel()
		{
		}
		public List<Character> Characters { get; set; }
		public Info PaginationInfo { get; set; }
	}
}
