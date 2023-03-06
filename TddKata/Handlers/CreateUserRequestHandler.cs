using TddKata.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using LanguageExt;

namespace TddKata.Handlers {
	public class CreateUserRequestHandler {
		public virtual Result<Unit> Execute(CreateUserRequest request) {
			return new Result<Unit>(Unit.Default);
		}
	}
}
