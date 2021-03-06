/**
 * @name Test for try catches
 */

import csharp

from Method m, TryStmt s, GeneralCatchClause c
where
  s.getEnclosingCallable() = m and
  m.getName() = "MainTryThrow" and
  s.getCatchClause(1) = c and
  c.getCaughtExceptionType().getName() = "Exception"
select c, c.getCaughtExceptionType().toString()
