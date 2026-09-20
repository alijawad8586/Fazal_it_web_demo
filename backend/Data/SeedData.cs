using FazalTechSolutions.Api.Models;

namespace FazalTechSolutions.Api.Data;

/// <summary>
/// Static in-memory content for the marketing site (services + blog).
/// Swap this out for a real database/CMS later — controllers only depend
/// on the lists below, not on how they're produced.
/// </summary>
public static class SeedData
{
    public static readonly List<ServiceItem> Services = new()
    {
        new ServiceItem
        {
            Id = 1,
            Slug = "website-development",
            Title = "Website Development",
            Summary = "Fast, responsive, and scalable websites.",
            Description = "We build custom websites from the ground up using modern frameworks, " +
                "focused on speed, scalability, and clean code that's easy to maintain and grow.",
            Icon = "code"
        },
        new ServiceItem
        {
            Id = 2,
            Slug = "website-design",
            Title = "Website Design",
            Summary = "Modern and user-friendly designs that represent your brand.",
            Description = "Our designs are crafted around your brand identity and your audience — " +
                "clean, modern, and built to guide visitors toward action.",
            Icon = "design"
        },
        new ServiceItem
        {
            Id = 3,
            Slug = "website-redesign",
            Title = "Website Redesign",
            Summary = "Transforming outdated websites into modern digital experiences.",
            Description = "We take your existing site and rebuild it with a modern look, better " +
                "performance, and a smoother experience for every visitor.",
            Icon = "refresh"
        },
        new ServiceItem
        {
            Id = 4,
            Slug = "website-maintenance",
            Title = "Website Maintenance",
            Summary = "Keeping websites secure, updated, and running smoothly.",
            Description = "Ongoing monitoring, updates, backups, and security checks so your " +
                "website keeps running smoothly long after launch.",
            Icon = "shield"
        },
        new ServiceItem
        {
            Id = 5,
            Slug = "bug-fixing-support",
            Title = "Bug Fixing & Technical Support",
            Summary = "Finding and resolving website problems.",
            Description = "From broken layouts to backend errors, we diagnose and fix issues " +
                "quickly so your website stays reliable for your customers.",
            Icon = "tool"
        },
        new ServiceItem
        {
            Id = 6,
            Slug = "ecommerce-development",
            Title = "E-commerce Development",
            Summary = "Helping businesses sell products and services online.",
            Description = "We build secure, scalable online stores with smooth checkout flows " +
                "so you can sell products and services with confidence.",
            Icon = "cart"
        },
        new ServiceItem
        {
            Id = 7,
            Slug = "ai-automation",
            Title = "AI & Automation Solutions",
            Summary = "Using modern AI technologies to automate tasks and improve business workflows.",
            Description = "We integrate modern AI tools and automation into your business " +
                "workflows to save time, reduce manual work, and improve efficiency.",
            Icon = "spark"
        },
    };

    public static readonly List<BlogPost> BlogPosts = new()
    {
        new BlogPost
        {
            Id = 1,
            Slug = "signs-your-business-needs-a-new-website",
            Title = "5 Signs Your Business Needs a New Website",
            Excerpt = "Slow load times, an outdated design, and a poor mobile experience can quietly " +
                "cost you customers. Here's how to know when it's time for a redesign.",
            Content = "An outdated website does more than look old — it actively works against your " +
                "business. If your site is slow, hard to use on mobile, or no longer reflects your " +
                "brand, visitors notice, and many leave before they even see what you offer.\n\n" +
                "A modern redesign focuses on speed, clarity, and a smooth experience on every device, " +
                "so your website starts working for your business again instead of against it.",
            Category = "Website Design",
            ReadTime = "4 min read",
            PublishedOn = new DateOnly(2026, 6, 12)
        },
        new BlogPost
        {
            Id = 2,
            Slug = "why-website-speed-matters-for-growth",
            Title = "Why Website Speed Matters More Than You Think",
            Excerpt = "A one-second delay in load time can significantly impact conversions. " +
                "Here's what actually affects speed and how we approach fixing it.",
            Content = "Website speed affects everything from search rankings to how long visitors " +
                "stay on your page. Large unoptimized images, bloated code, and poor hosting are the " +
                "most common culprits.\n\nWe approach performance holistically — optimizing assets, " +
                "cleaning up code, and choosing the right infrastructure — so your site loads quickly " +
                "everywhere, not just on a good connection.",
            Category = "Performance",
            ReadTime = "5 min read",
            PublishedOn = new DateOnly(2026, 5, 28)
        },
        new BlogPost
        {
            Id = 3,
            Slug = "ecommerce-checklist-before-launch",
            Title = "The E-commerce Launch Checklist Every Store Needs",
            Excerpt = "From secure payments to mobile checkout, here are the essentials we verify " +
                "before any online store goes live.",
            Content = "Launching an online store involves more than listing products. Payment " +
                "security, mobile checkout, page speed, and clear product information all directly " +
                "affect whether a visitor completes a purchase.\n\nBefore any store we build goes live, " +
                "we run it through a full checklist covering security, usability, and performance, so " +
                "it's ready to sell from day one.",
            Category = "E-Commerce",
            ReadTime = "6 min read",
            PublishedOn = new DateOnly(2026, 5, 10)
        },
        new BlogPost
        {
            Id = 4,
            Slug = "how-automation-saves-business-hours",
            Title = "How Simple Automation Can Save Your Business Hours Every Week",
            Excerpt = "Automation doesn't have to mean a full AI overhaul. Small, well-placed " +
                "automations often deliver the biggest time savings.",
            Content = "Many businesses assume automation requires a large investment, but some of " +
                "the most valuable automations are small — auto-responding to inquiries, syncing data " +
                "between tools, or generating routine reports automatically.\n\nWe start by identifying " +
                "the repetitive tasks that eat up the most time, then build focused automations around " +
                "them, so the effort matches the return.",
            Category = "AI & Automation",
            ReadTime = "5 min read",
            PublishedOn = new DateOnly(2026, 4, 22)
        },
        new BlogPost
        {
            Id = 5,
            Slug = "website-maintenance-why-it-matters",
            Title = "Why Your Website Still Needs Attention After Launch",
            Excerpt = "Launching a website is the beginning, not the end. Here's what ongoing " +
                "maintenance actually protects you from.",
            Content = "A website that isn't maintained gradually accumulates risk — outdated " +
                "plugins, expired certificates, and unpatched vulnerabilities all build up quietly " +
                "over time.\n\nRegular maintenance catches these issues early, keeping your site " +
                "secure, fast, and reliable long after the initial launch.",
            Category = "Maintenance",
            ReadTime = "4 min read",
            PublishedOn = new DateOnly(2026, 4, 3)
        },
    };
}
