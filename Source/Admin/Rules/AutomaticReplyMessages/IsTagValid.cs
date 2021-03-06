/*---------------------------------------------------------------------------------------------
 *  Copyright (c) The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System.Linq;
using Dolittle.Rules;

namespace Rules.AutomaticReplyMessages
{
    public class IsTagValid : IRuleImplementationFor<Domain.AutomaticReplyMessages.IsTagValid>
    {
        public Domain.AutomaticReplyMessages.IsTagValid Rule => tag => !string.IsNullOrWhiteSpace(tag) && tag.All(char.IsLetterOrDigit);
    }
}
