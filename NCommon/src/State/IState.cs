#region license
//Copyright 2010 Ritesh Rao 

//Licensed under the Apache License, Version 2.0 (the "License"); 
//you may not use this file except in compliance with the License. 
//You may obtain a copy of the License at 

//http://www.apache.org/licenses/LICENSE-2.0 

//Unless required by applicable law or agreed to in writing, software 
//distributed under the License is distributed on an "AS IS" BASIS, 
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
//See the License for the specific language governing permissions and 
//limitations under the License. 
#endregion

namespace NCommon.State
{
    /// <summary>
    /// Base IState interface.
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// Gets the application specific state.
        /// </summary>
        IApplicationState Application { get; }

        /// <summary>
        /// Gets the session specific state.
        /// </summary>
        ISessionState Session { get; }

        /// <summary>
        /// Gets the cache specific state.
        /// </summary>
        ICacheState Cache { get; }

        /// <summary>
        /// Gets the thread local / request local specific state.
        /// </summary>
        ILocalState Local { get; }
    }
}