﻿using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Git
{
    public class GitCloneTask : ExternalProcessTaskBase<GitCloneTask>
    {
        public GitCloneTask(string repository, string directory)
        {
            InsertArgument(0, repository);
            InsertArgument(1, directory);
        }

         protected override string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// checkout specified branch instead of the remote's HEAD.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public GitCloneTask Branch(string name)
        {
            WithArguments("--branch", name);
            return this;
        }

        /// <summary>
        /// force progress reporting.
        /// </summary>
        /// <returns></returns>
        public GitCloneTask ShowProgress()
        {
            WithArguments("--progress");
            return this;
        }

        /// <summary>
        /// be more verbose.
        /// </summary>
        /// <returns></returns>
        public GitCloneTask Verbose()
        {
            WithArguments("--verbose");
            return this;
        }

        /// <summary>
        /// be more quiet.
        /// </summary>
        /// <returns></returns>
        public GitCloneTask Quiet()
        {
            WithArguments("--quit");
            return this;
        }

        /// <summary>
        /// don't create a checkout
        /// </summary>
        /// <returns></returns>
        public GitCloneTask NoCheckout()
        {
            WithArguments("--no-checkout");
            return this;
        }

        /// <summary>
        /// create a bare repository.
        /// </summary>
        /// <returns></returns>
        public GitCloneTask CreateBareRepository()
        {
            WithArguments("--bare");
            return this;
        }

        /// <summary>
        /// setup as shared repository.
        /// </summary>
        /// <returns></returns>
        public GitCloneTask SetupAsSharedRepository()
        {
            WithArguments("--shared");
            return this;
        }
    }
}
