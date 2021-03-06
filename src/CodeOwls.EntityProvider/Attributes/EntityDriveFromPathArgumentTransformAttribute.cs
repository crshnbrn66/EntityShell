﻿using System;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace CodeOwls.EntityProvider.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class EntityDriveFromPathArgumentTransformAttribute : ArgumentTransformationAttribute
    {
        public override object Transform(EngineIntrinsics engineIntrinsics, object inputData)
        {
            if (null == inputData)
            {
                inputData = ".";
            }

            var path = inputData.ToString();

            var drive = MetadataHelpers.GetEntityDriveFromPSPath(engineIntrinsics.SessionState.Path, path);

            return drive;
        }
    }
}
