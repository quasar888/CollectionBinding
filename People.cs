// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.ObjectModel;

namespace CollectionBinding
{
    public class People : ObservableCollection<Person>
    {
        public People()
        {
            Add(new Person("Alexander", "Bellevue"));
            Add(new Person( "Hay", "Redmond"));
            Add(new Person( "Lee", "Kirkland"));
            Add(new Person( "Smith", "Seattle"));
            Add(new Person("Xplain", "Madrid"));

        }
    }
}