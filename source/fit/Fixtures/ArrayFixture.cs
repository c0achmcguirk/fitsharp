// Copyright � 2010 Syterra Software Inc.
// This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License version 2.
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.

using System.Collections;
using System.Data;
using fit.Operators;

namespace fitlibrary {

    public class ArrayFixture: NamedCollectionFixtureBase {

        public ArrayFixture(object[] theArray): base(theArray) {}

        public ArrayFixture(ICollection theCollection): base(theCollection) {}

        public ArrayFixture(IEnumerator theEnumerator): base(theEnumerator) {}

        public ArrayFixture(DataTable theTable): base(theTable.Rows.GetEnumerator()) {}

        protected override ListMatchStrategy MatchStrategy {
            get {
                return new ArrayMatchStrategy(Processor, myHeaderRow);
            }
        }
    }

}
