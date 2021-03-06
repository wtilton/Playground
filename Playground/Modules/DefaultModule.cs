﻿using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Playground.Modules
{
	public class DefaultModule : NancyModule
	{
		public DefaultModule()
		{
			Get["/"] = p => { return View["Index"]; };
			Get["/knockout"] = p => { return View["Knockout"]; };
			Get["/durandal"] = p => { return View["Durandal"]; };
			Get["/durandal/tests"] = p => { return View["DurandalSpecs"]; };
			Get["/castlevania"] = _ => { return View["CastleVania"]; };
			Get["/golf"] = _ => { return View["Golf"]; };
			Get["/BasketballStats"] = _ => { return View["BasketballStats"]; };
			Get["/Water"] = _ => { return View["Water"]; };
		}
	}
}