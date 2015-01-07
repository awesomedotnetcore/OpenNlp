﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenNLP.Tools.Util.Ling;

namespace OpenNLP.Tools.Util.Trees
{
    /// <summary>
    /// Set of common annotations for {@link edu.stanford.nlp.util.CoreMap}s 
    /// that require classes from the trees package.  See 
    /// {@link edu.stanford.nlp.ling.CoreAnnotations} for more information.
    /// This class exists so that
    /// {@link edu.stanford.nlp.ling.CoreAnnotations} need not depend on
    /// trees classes, making distributions easier.
    /// 
    /// @author Anna Rafferty
    /// 
    /// Code...
    /// </summary>
    public static class TreeCoreAnnotations
    {
        /// <summary>
        /// The CoreMap key for getting the syntactic parse tree of a sentence.
        /// This key is typically set on sentence annotations.
        /// </summary>
        public class TreeAnnotation : CoreAnnotation<Tree>
        {
            public Type GetAnnotationType()
            {
                return typeof (Tree);
            }
        }

        /// <summary>
        /// The CoreMap key for getting the binarized version of the
        /// syntactic parse tree of a sentence.
        /// This key is typically set on sentence annotations.  It is only
        /// set if the parser annotator was specifically set to parse with
        /// this (parse.saveBinarized).  The sentiment annotator requires
        /// this kind of tree, but otherwise it is not typically used.
        /// </summary>
        public class BinarizedTreeAnnotation : CoreAnnotation<Tree>
        {
            public Type GetAnnotationType()
            {
                return typeof (Tree);
            }
        }

        /// <summary>
        /// The standard key for storing a head word in the map as a pointer to another node
        /// </summary>
        public class HeadWordAnnotation : CoreAnnotation<Tree>
        {
            public Type GetAnnotationType()
            {
                return typeof (Tree);
            }
        }

        /// <summary>
        /// The standard key for storing a head tag in the map as a pointer to another node
        /// </summary>
        public class HeadTagAnnotation : CoreAnnotation<Tree>
        {
            public Type GetAnnotationType()
            {
                return typeof (Tree);
            }
        }
    }
}