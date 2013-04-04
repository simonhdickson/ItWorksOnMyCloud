using System;
using System.Collections.Generic;
using ItWorksOnMyCloudSite.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace ItWorksOnMyCloudSite
{
    public class BlogService
    {
        private readonly CloudBlobContainer container;

        public BlogService(CloudBlobContainer container)
        {
            this.container = container;
        }

        public IEnumerable<Post> GetBlogPosts(int skip = 0, int take = 5)
        {
            container.SetPermissions(
                new BlobContainerPermissions
                    {
                        PublicAccess =
                            BlobContainerPublicAccessType.Blob
                    });

            return new ArraySegment<Post>();
        }
    }
}