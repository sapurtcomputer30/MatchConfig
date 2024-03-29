﻿using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchConfig.Matchers
{
    public class VmessMatcher:MatcherBase
    {
        private Regex _regex;

        public VmessMatcher()
            => _regex = new Regex(Patterns.VmessPattern, DefaultMatcherOptions);


        public override List<string> Match(string input)
            => _regex.Matches(input).ToMatchList().Distinct().ToList();


        public override MatcherTypes MatcherType => MatcherTypes.Vmess;
    }
}